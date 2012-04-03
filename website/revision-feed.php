<?php

$postCount = filter_var($_GET['limit'], FILTER_VALIDATE_INT, 
	array('options' => array('min_range' => 1, 'max_range' => 20)));

// XSLT wrapper.
function xslTransform($xml, $xslt) { 
	$xsltProcessor = new XSLTProcessor(); 
	$xsltProcessor->importStylesheet(new  SimpleXMLElement($xslt)); 
	return $xsltProcessor->transformToXml(new SimpleXMLElement($xml)); 
}

// Transform the Atom XML into a list of links.
// Optionally use an SVN path.
$xslt = file_get_contents('revision-feed.xsl');
$xmlpath = 'http://code.google.com/feeds/p/msile/svnchanges/basic';
$svnpath = $_GET['path'];
($svnpath) && $xmlpath .= "?path=$svnpath";
$xml = file_get_contents($xmlpath);
$transformed = xslTransform($xml, $xslt);

// Get a specified maximum number of them.
$matches = array();

// use the "?limit=" URL parameter if in the correct range, or 9.
$pattern = '_(\<a[^>]*\>[^<]*\</a\>\<br/\>){1,';
if ($postCount) {
	$pattern .= "$postCount}_";
} else {
	$pattern .= '9}_';
}
preg_match($pattern, $transformed, $matches);

echo $matches[0];

?>