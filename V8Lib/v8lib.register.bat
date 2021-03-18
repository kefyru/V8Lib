@echo off
curl https://github.com/kefyru/V8Lib/blob/master/V8Lib/v8lib.update.bat --output %ProgramFiles\1cv8\v8lib\v8lib.update.bat
curl https://github.com/kefyru/V8Lib/blob/master/V8Lib/bin/Debug/V8Lib.dll --output %ProgramFiles\1cv8\v8lib\V8Lib.dll
curl https://github.com/kefyru/V8Lib/blob/master/V8Lib/bin/Debug/V8Lib.pdb --output %ProgramFiles\1cv8\v8lib\V8Lib.pdb
C:\Windows\Microsoft.NET\Framework\v4.0.30319\regasm.exe %ProgramFiles\1cv8\v8lib\V8Lib.dll /tlb /codebase /verbose