# ANDROIDcontrolAPP
FOR PART A (EVEN)
AGRITA ANAND
012300300002004006


✅ Step 1: Connect the Android device via ADB
Make sure:

USB Debugging is enabled on your phone

ADB is installed (adb devices should show your device ID)


adb devices
✅ Step 2: Extract Required Information
1. Contacts List
Contacts are stored in:


/data/data/com.android.providers.contacts/databases/contacts2.db


📌 Command:


adb shell content query --uri content://contacts/phones/
🔒 Note: This requires root access or your app must be installed as a system app on the device. Alternatively, extract the DB file:


adb root
adb pull /data/data/com.android.providers.contacts/databases/contacts2.db


2. SMS Messages


SMS are stored in:
/data/data/com.android.providers.telephony/databases/mmssms.db
📌 Command:
adb shell content query --uri content://sms/


3. Call Logs
Call logs URI:


content://call_log/calls
📌 Command:


adb shell content query --uri content://call_log/calls
4. Device CPU and Memory Info
📌 CPU Info:


adb shell cat /proc/cpuinfo
📌 Memory Info:


adb shell cat /proc/meminfo
5. Login Accounts (Google or others)
📌 Command:

adb shell dumpsys account
This will list all user accounts configured on the device.

6. Other Info
📌 Device Model:

adb shell getprop ro.product.model
📌 Android Version:

adb shell getprop ro.build.version.release
📌 Battery Status:
adb shell dumpsys battery
📌 IMEI Number (may require permissions/root):

adb shell service call iphonesubinfo 1
📌 For dual SIMs:

adb shell service call iphonesubinfo 2
📌 Installed Apps:

adb shell pm list packages
