{-# LANGUAGE LambdaCase #-}
{-# LANGUAGE DeriveDataTypeable  #-}
{-# LANGUAGE OverloadedStrings #-}
module Eval.Parse.Error where

import Data.Data
import Data.List (intercalate)
import Data.List.NonEmpty (NonEmpty (..))
import Data.Maybe (isNothing, fromJust)
import Data.Set (Set)
import Data.Text (Text)
import Data.Proxy
import Data.Void

import Text.Megaparsec
import Text.Megaparsec.Error


import qualified Data.List.NonEmpty as NE
import qualified Data.Set           as E


data ExprError = MissingParen
  deriving (Eq, Data, Typeable, Ord, Read, Show)


showErrorBundle :: ParseErrorBundle Text ExprError -> String
showErrorBundle (ParseErrorBundle (err:|_) _) =
  showError err


showError :: ParseError Text ExprError -> String
showError (TrivialError _ us ps) =
  if isNothing us && E.null ps
    then "Encountered unknown parse error!"
    else "unexpected " <> (showErrorItem pxy (fromJust us))
  where
    pxy = Proxy :: Proxy Text

showError (FancyError _ _) =
  "Missing ')'"


showErrorItem :: Proxy Text -> ErrorItem (Token Text) -> String
showErrorItem pxy = \case
    Tokens   ts -> showTokens pxy ts
    Label label -> NE.toList label
    EndOfInput  -> "end of input"
