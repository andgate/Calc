{-# LANGUAGE OverloadedStrings #-}
module Eval.Parse where

import Eval.AST
import Eval.Parse.Error

import Control.Monad.Combinators.Expr
import Data.Text (Text, pack)
import Data.Void
import Text.Megaparsec
import Text.Megaparsec.Char

import qualified Text.Megaparsec.Char.Lexer as L
import qualified Data.Set as S


type Parser = Parsec ExprError Text

parseExp :: String -> Either String AST
parseExp input =
  case parse (expP <* eof) "" (pack input) of
    Left  eb  -> Left (showErrorBundle eb)
    Right ast -> Right ast



sc :: Parser ()
sc = L.space space1 empty empty

lexeme  = L.lexeme sc

lparen = L.symbol sc "("
rparen = L.symbol sc ")"

parensP :: Parser a -> Parser a
parensP = between lparen rparen

integerP :: Parser Integer
integerP = L.signed sc (lexeme L.decimal)

doubleP :: Parser Double
doubleP = L.signed sc (lexeme L.float)

expP :: Parser AST
expP = makeExprParser termP table <?> "expression"

termP :: Parser AST
termP = ( Val    <$> (   try doubleP
                     <|> (fromInteger <$> integerP)
                     ) <?> "number"
        )
    <|> expParensP


expParensP :: Parser AST
expParensP =
        try (Parens <$> parensP expP )
   <|> (lparen *> expP *> customFailure MissingParen)


table = [ [ binary "^"  (BinOp OpPow)]
        , [ binary  "*"  (BinOp OpMul), binary  "/"  (BinOp OpDiv)  ]
        , [ binary  "+"  (BinOp OpAdd), binary  "-"  (BinOp OpSub)  ]
        ]

-- Left associative binary operation
binary  name f = InfixL  (f <$ L.symbol sc name)
