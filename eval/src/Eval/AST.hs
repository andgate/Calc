{-# LANGUAGE LambdaCase #-}
module Eval.AST where

data Op1
  = OpPos
  | OpNeg

data Op2
  = OpAdd
  | OpSub
  | OpMul
  | OpDiv
  | OpPow

data AST
  = Val Double
  | UnOp Op1 AST
  | BinOp Op2 AST AST
  | Parens AST



simplify :: AST -> Double
simplify = \case
  Val x     -> x

  UnOp op a ->
    let a' = simplify a
    in
      case op of
        OpPos -> a'
        OpNeg -> negate a'

  BinOp op a b ->
    let a' = simplify a
        b' = simplify b
    in
      case op of
        OpAdd -> a' + b'
        OpSub -> a' - b'
        OpMul -> a' * b'
        OpDiv | b' /= 0 -> a' / b'
              | b' == 0 -> 0/0 -- Should return NaN
        OpPow -> a' ** b'
  Parens e -> simplify e
