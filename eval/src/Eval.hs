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
    Left  msg -> msg
    Right e   ->
      let r = simplify e
          output = show r
      in
        if r == fromIntegral (truncate r)
          then take (length output - 2) output
          else show r




foreign export ccall eval :: CString -> IO CString
