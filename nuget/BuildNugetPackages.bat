set PKG_VER=2017.1.1
nuget pack ../DataConversionExtensions/DataConversionExtensions.nuspec  -Version %PKG_VER%  -o  ../../NugetPackages
pause