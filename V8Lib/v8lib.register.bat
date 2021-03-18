@echo off
curl https://raw.githubusercontent.com/kefyru/V8Lib/master/V8Lib/v8lib.update.bat?token=AG6LFJW3TZSQGEKVGWPMRE3AKNL6M --create-dirs --output %ProgramFiles\1cv8\v8lib\v8lib.update.bat
curl https://raw.githubusercontent.com/kefyru/V8Lib/master/V8Lib/bin/Debug/V8Lib.dll?token=AG6LFJQJ7OHWYQ2WGRN75SDAKNMBS --create-dirs --output %ProgramFiles\1cv8\v8lib\V8Lib.dll
curl https://raw.githubusercontent.com/kefyru/V8Lib/master/V8Lib/bin/Debug/V8Lib.pdb?token=AG6LFJTJKUUD64TK6LWZ3F3AKNMDU --create-dirs --output %ProgramFiles\1cv8\v8lib\V8Lib.pdb
%SystemRoot%\Microsoft.NET\Framework\v4.0.30319\regasm.exe %ProgramFiles\1cv8\v8lib\V8Lib.dll /tlb /codebase /verbose