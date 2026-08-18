# --------------------------------------------------------------
# Text files under /sandbox are automatically returned...
source ~/cyber_dojo_fs_cleaners.sh

function cyber_dojo_enter()
{
  : # 1. Only return _newly_ generated reports.
}
function cyber_dojo_exit()
{
  : # 2. Remove new text files we don't want returned.
  cyber_dojo_delete_files TestResult.xml
}
cyber_dojo_enter
trap cyber_dojo_exit EXIT SIGTERM

readonly SDK=/usr/share/dotnet/sdk/10.0.103

# The compiler needs to write FSharp.Core.dll into this dir, so it must not be
# symlinked here the way nunit.framework.dll is.
ln -s ~/.nuget/packages/nunit/4.3.2/lib/net8.0/nunit.framework.dll nunit.framework.dll

# --targetprofile:netcore is required. Without it fsc assumes the .NET Framework
# profile and fails looking for System.Runtime.Remoting.dll and friends.
# The .fs files are named rather than globbed because F# compiles in the order
# given, and a test file has to follow what it tests.
time (dotnet ${SDK}/FSharp/fsc.dll \
  --nologo \
  --target:library \
  --targetprofile:netcore \
  -r:nunit.framework.dll \
  -o:dojo.dll \
  Hiker.fs HikerTest.fs \
  && ~/.dotnet/tools/nunit dojo.dll --noheader --noresult --nocolor)
