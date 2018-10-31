{-# LANGUAGE LambdaCase #-}
module Eval.AST where

data Op
  = OpAdd
  | OpSub
  | OpMul
  | OpDiv
  | OpPow

data AST
  = Val Double
  | BinOp Op AST AST
  | Parens AST



simplify :: AST -> Double
simplify = \case
  Val x     -> x

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
