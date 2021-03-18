@echo off
curl "https://raw.githubusercontent.com/kefyru/V8Lib/master/VLib/v8lib.update.bat" --create-dirs --output "%ProgramFiles%\1cv8\v8lib\v8lib.update.bat"
curl "https://raw.githubusercontent.com/kefyru/V8Lib/master/VLib/bin/Debug/VLib.dll" --create-dirs --output "%ProgramFiles%\1cv8\v8lib\VLib.dll"
curl "https://raw.githubusercontent.com/kefyru/V8Lib/master/VLib/bin/Debug/VLib.pdb" --create-dirs --output "%ProgramFiles%\1cv8\v8lib\VLib.pdb"
"%SystemRoot%\Microsoft.NET\Framework\v4.0.30319\regasm.exe" "%ProgramFiles%\1cv8\v8lib\VLib.dll" /tlb /codebase /verbose
"%SystemRoot%\Microsoft.NET\Framework64\v4.0.30319\regasm.exe" "%ProgramFiles%\1cv8\v8lib\VLib.dll" /tlb /codebase /verbose