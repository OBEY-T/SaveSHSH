# SaveSHSH

Provision of a GUI for tihmstar's TSSChecker.

Make sure tsschecker.exe is in the \bin\Debug folder of the project to run the program inside Visual Studio.

# tsschecker (encounter fork)
_tsschecker is a powerful tool to check tss signing status of various devices and iOS versions._

Latest compiled version can be found here:  
(macOS & Windows)  
https://github.com/encounter/tsschecker/releases

## Features  
* Allows you to get lists of all devices and all iOS/OTA versions for a specific device.
* Can check signing status for default iOS versions and beta ipsws (by specifying a `BuildManifest.plist`)
* Works without specifying any device relevant values to check signing status, but can be used to save blobs when given an ECID and the option `--print-tss-response` (although there are better tools to do this).

tsschecker is not only meant to be used to check signing status, but also to explore Apple's tss servers.
By using all of its customization possibilities, you might discover a combination of devices and iOS versions that is now getting signed but wasn't getting signed before.  

# Dependencies
*  ## Bundled Libs
  Those don't need to be installed manually
  * [tss](https://github.com/libimobiledevice)
* ## External Libs
  Make sure these are installed
  * [libcurl](https://curl.haxx.se/libcurl/)
  * [libplist](https://github.com/libimobiledevice/libplist)
  * [libfragmentzip](https://github.com/tihmstar/libfragmentzip)
* ## Submodules
  Make sure these projects compile on your system
  * [jssy](https://github.com/tihmstar/jssy)


## tsschecker help  
_(might become outdated):_

Usage: `tsschecker [OPTIONS]`

| option (short) | option (long)             | description                                                                       |
|----------------|---------------------------|-----------------------------------------------------------------------------------|
|  `-d`          | `--device MODEL`          | specify device by its MODEL (eg. `iPhone4,1`)                                     |
|  `-i`          | `--ios VERSION`           | specify iOS version (eg. `6.1.3`)                                                 |
|				         | `--buildid BUILDID`		   | specific buildid instead of iOS version (eg. `13C75`)							               |
|				         | `--boardconfig BOARD`	   | specific boardconfig instead of iPhone model (eg. `n61ap`)						             |
|  `-h`          | `--help`                  | prints usage information                                                          |
|  `-o`          | `--ota`	                 | check OTA signing status, instead of normal restore                               |
|  `-b`          | `--no-baseband`           | don't check baseband signing status. Request a ticket without baseband            |
|  `-m`          |`--build-manifest MANIFEST`| manually specify buildmanifest. (can be used with `-d`)                           |  
|  `-s`          | `--save`		     		       | save fetched shsh blobs (mostly makes sense with -e)                              |
|  `-l`			     | `--latest`  				       | use latest public iOS version instead of manually specifying one<br>especially useful with `-s` and `-e` for saving blobs                                                                                              |
|      			     | `--apnonce NONCE`   		   | manually specify APNONCE instead of using random one (not required for saving blobs)|
|      			     | `--sepnonce NONCE`        | manually specify SEPNONCE instead of using random one (not required for saving blobs) 		                                                                                                                                  |
|      			     | `--save-path PATH`        | specify path for saving blobs 		 														 |
|  `-e`          | `--ecid ECID`	         | manually specify an ECID to be used for fetching blobs, instead of using random ones. <br>ECID must be either dec or hex eg. `5482657301265` or `ab46efcbf71`                                                          |
|                |  `--beta`	             | request ticket for beta instead of normal release (use with `-o`)                |
|                | `--list-devices`          | list all known devices                                                            |
|                |`--list-ios`	             | list all known iOS versions                                                       |
|                |`--nocache`       	     | ignore caches and re-download required files                                      |
|                |`--print-tss-request`      | prints tss request that will be sent (plist)                                      |
|                |`--print-tss-response`     | prints tss response that come from Apple (plist)                                  |
