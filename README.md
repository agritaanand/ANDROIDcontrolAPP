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





FOR PART B (EVEN)
AGRITA ANAND
012300300002004006



✅ Overview of Part B Requirements
 NAME OF THE APP
    "ANDROID CONTROL APPLICATION"
BUILDING C# Windows Forms application with:

Sections/forms for:

Contacts

SMS

Call Logs

Device Info

Login Accounts

Navigation using either:

MDI (Multiple forms in one parent window) ✅ Recommended for you.

or SDI (Single Form with dynamic content).

Functional buttons on each form:

Load Data: Run ADB command and show result.

Save to Database: Save output to SQL Server.

Generate Report: Export to PDF or text.



ADDITION IN PART B FROM MY SIDE :
BUILD ANOTHER C# Windows Forms application 
NAME OF THE APPLICATION 
      "LPW4006"


1. Setup Prerequisites
Tools Required:

Visual Studio (for C#/.NET development)

Android SDK Platform Tools (ADB executable: adb.exe, AdbWinApi.dll, AdbWinUsbApi.dll)

Android Device:

Enable USB Debugging (Settings > Developer Options).

Use a compatible data cable.

2. Create a C# Windows Forms Project
Open Visual Studio and create a Windows Forms App (.NET Framework).

Design the GUI with:

Buttons: Connect Device, Extract SMS, Extract Calls, Generate Report.

DataGridView/ListView to display results.

Status bar for connection/error messages.

3. Integrate ADB into the Project
Include ADB Files:

Copy adb.exe, AdbWinApi.dll, and AdbWinUsbApi.dll into your project directory.

In Visual Studio, add these files to your project and set their properties to Copy to Output Directory: Copy always.




4.. Handle Permissions and Errors
Device Authorization: Ensure the user grants USB debugging access on the device.

Error Handling: Wrap ADB commands in try-catch blocks and display errors in the UI.




5.Test the Application
Connect the Android device via USB.

Run the app and click Connect.

Extract data (SMS, calls, installed apps).

Generate and verify the report.










