set PKG_VER=2018.1.1
nuget pack ../DataConversionExtensions/DataConversionExtensions.nuspec  -Prop Configuration=Release -Version %PKG_VER%  -o  ../../NugetPackages
pause