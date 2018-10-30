cd eval
cabal sandbox init
cabal install --dependencies-only
cabal build
cd ..

copy "%cd%\eval\dist\build\eval\eval.dll" "%cd%\Calc\"
