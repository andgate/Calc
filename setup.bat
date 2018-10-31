cd eval
REM cabal update
REM cabal sandbox init
REM cabal install --dependencies-only
cabal build
cd ..

copy "%cd%\eval\dist\build\eval\eval.dll" "%cd%\Calc\"
