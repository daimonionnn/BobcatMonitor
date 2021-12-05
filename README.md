# Bobcat Monitor and JumpStarter v 0.62 for Windows
Bobcat helium miner monitoring and reset/resync tool for Windows

# Description
Bobcat Monitor monitors blockchain Gap and other parameters.
If Gap goes above specified threshold (default 20), Bobcat will be automatically cycled - Reset + Fast sync  or  Reset + Resync + Fast sync.

It was developed especially for (but not only) defective and slow Bobcats - some of them are resetting several times a day and are unable to sync.
The only temporary solution to fix this is RESET + FAST SYNC or RESYNC + FAST SYNC.
This tool also helps if your (100% working) Bobcat hangs after OTA, goes off chain and needs resync.


# Installation
Download zip file from Binaries directory, extract and run

# Platform
This is Windows only application (Windows forms, .net framework 4.7.2) but I plan cmd app for Linux and Windows. 

# Donation

If you like this app and would like to support further development (Linux and cmd version), you can donate some fraction of HNT to my address: 
13dxLUHWhhxpNRjqLtmxF22ANeoLXPZe3c7JRCJjUJwKgiUJ6Z5

Thank You

# Release info

v 0.62
- Changed types of reset operation and added Reboot
- Added manual controls (Reboot, Resync, Fast sync, Reset)


v 0.61
- Added monitoring property "errors"
- Delay times changed from seconds to minutes
- Adjusted default delay times to higher/safer values
- Minor fixes

v 0.6
- Added 2 new types of Reset operarion - "Reset" and "Reset + Resync" (without Fast sync) 
- Fast sync will not run if miner is not responding after Reset/Resync operation (Message was displayed "Fast syncing...", but it actually did nothing)
- Default reset operation is now set to "Disabled"
- Changed default pause value after RESET/SYN to 7200 second (2 hours)
- Changed default GAP threshold to 30

v 0.5
Fixed GAP - gap was not correctly displayed (Bobcat changed parameters miner_height and blockchain_height in previous firmware)

v 0.4
Fast sync will be not run if Gap after reset/resync is below 400.

v 0.3
Fixed bug when monitoring was stopped after unsuccessful data read from Bobcat (or appeared like it stopped as Start monitoring button was activated)

Added autoscroll to status box

v 0.2
Project was renamed from Bobcat Recycler to Bobcat Monitor and JumpStarter

Some bug fixes and adjusted default delay/pause times

v 0.1
First version
