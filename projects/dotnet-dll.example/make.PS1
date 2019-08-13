$ROOT_PATH = Get-Location
$CONSOLE_PATH = "$($ROOT_PATH)/console"
$CONSOLE_LIB_PATH = "$($CONSOLE_PATH)/lib"
$CLASSLIB_PATH = "$($ROOT_PATH)/classlib"
$CLASSLIB_LIB_PATH = "$($CLASSLIB_PATH)/bin/Debug/netstandard2.0"
$CPPCLASSLIB_PATH = "$($ROOT_PATH)/cppclasslib"
$CPPCLASSLIB_LIB_PATH = "$($CPPCLASSLIB_PATH)/x64/Debug"



Set-Location $CLASSLIB_PATH
dotnet.exe build
New-Item -Force -ItemType directory -Path $CONSOLE_LIB_PATH
Move-Item -Force "$($CLASSLIB_LIB_PATH)\classlib.dll" $CONSOLE_LIB_PATH


Set-Location $CPPCLASSLIB_PATH
msbuild.exe cppclasslib.sln
Move-Item -Force "$($CPPCLASSLIB_LIB_PATH)\cppclasslib.dll" $CONSOLE_LIB_PATH

Set-Location $CONSOLE_PATH
dotnet.exe run



# Set-Location $CLASSLIB_PATH
# dotnet.exe clean
# Set-Location $CONSOLE_PATH
# dotnet.exe clean
# Remove-Item -r $CONSOLE_LIB_PATH
# Set-Location $CPPCLASSLIB_PATH
# Remove-Item -r "$($CPPCLASSLIB_PATH)/x86"

Set-Location $ROOT_PATH