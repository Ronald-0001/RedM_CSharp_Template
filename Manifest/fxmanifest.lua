fx_version 'bodacious'
game 'rdr3'
rdr3_warning 'I acknowledge that this is a prerelease build of RedM, and I am aware my resources *will* become incompatible once RedM ships.'

ui_page 'Client/nui/index.html'

files {
	'Client/nui/*.js',
	'Client/nui/*.css',
	'Client/nui/*.html',
	'Client/nui/Dependent/*.js',
	'Client/bin/publish/*.dll',
}

client_script 'Client/bin/publish/*.net.dll'
server_script 'Server/bin/publish/*.net.dll'

author 'Ronald#1000'
version '1.0.0'
description 'Main'