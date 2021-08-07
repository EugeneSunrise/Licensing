## Application Licensing Program

Using Library ([CryptHWID](https://github.com/EugeneSunrise/CryptHWID))

1. Id is sent to you by the user who needs to issue a license.
2. The software generates a key, which you send to the user, with its help the license is activated.


# Using

On the user side, checking for a license:

if (License.CheckLic ("SOFT"))

  {
    do smh ...
  }
  
else

  {
    string uhid = License.GetUHId (); // Get HWID and the user sends it to you
  }

The user enters enters the key you issued ->
License.ActivatedLicense ("Soft", Key);


# Regedit Path

The path to the license in the registry:

HKEY_CURRENT_USER\SOFTWARE\Mix\Soft (SOFTWARE \ Mix - you can change it in CryptId.dll)
