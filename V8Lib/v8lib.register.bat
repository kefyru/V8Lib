@echo off
curl https://github.com/kefyru/V8Lib/master/V8Lib/v8lib.update.bat?raw=true --create-dirs --output %ProgramFiles\1cv8\v8lib\v8lib.update.bat
curl https://github.com/kefyru/V8Lib/blob/master/V8Lib/bin/Debug/V8Lib.dll?raw=true --create-dirs --output %ProgramFiles\1cv8\v8lib\V8Lib.dll
curl https://github.com/kefyru/V8Lib/blob/master/V8Lib/bin/Debug/V8Lib.pdb?raw=true --create-dirs --output %ProgramFiles\1cv8\v8lib\V8Lib.pdb
%SystemRoot%\Microsoft.NET\Framework\v4.0.30319\regasm.exe %ProgramFiles\1cv8\v8lib\V8Lib.dll /tlb /codebase /verbose