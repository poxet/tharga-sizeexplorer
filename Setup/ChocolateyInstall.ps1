$packageName = 'windirstat'
$fileType = 'msi'
$url = 'http://www.thargelion.net/Resources/Release/Tharga.SizeExplorer.1.0.1.msi'
$silentArgs = '/q'

Install-ChocolateyPackage $packageName $fileType "$silentArgs" "$url"