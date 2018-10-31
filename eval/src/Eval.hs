module Eval where

import Eval.Parse
import Eval.AST
import Foreign.C.String
import Foreign.Marshal.Alloc

eval :: CString -> IO CString
eval input =
  peekCAString input >>= (newCString . eval')

eval' :: String -> String
eval' input =
  case parseExp input of
    Left  msg -> "ERROR: " ++ show input ++ "\n" ++ msg
    Right e   -> input ++ " = " ++ sanitize (simplify e)


sanitize :: Double -> String
sanitize x
  | x == fromIntegral (truncate x)
      = take (length str - 2) str
  | otherwise = str
  where
    str = show x


foreign export ccall eval :: CString -> IO CString
