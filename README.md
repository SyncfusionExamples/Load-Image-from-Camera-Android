# Load-Image-from-Camera-Android
This repository contains sample on how to load the image from Camera into the [Syncfusion Xamarin.Android SfImageEditor](https://help.syncfusion.com/cr/xamarin-android/Syncfusion.SfImageEditor.Android.SfImageEditor.html) control.

## Syncfusion controls:

This project used the following Syncfusion control(s):
* SfImageEditor

## Supported platforms

<table>
    <tr>
        <th>Platform<br/>
            <br/></th>        
        <th>
          Device Types
            <br/>
            <br/>
        </th>
          <th>
            Controls
            <br/>
            <br/>
        </th>
        <th>
            Supported versions
            <br/>
            <br/>
        </th>
    </tr>
    <tr>
        <td rowspan="2">
            Android
            <br/>
            <br/>
        </td>
        <td rowspan="2">
        Phone, Tablet
        <br/>
        <br/>
        </td>
        <td>
            SfPdfViewer, SfCheckBox
            <br/>
            <br/>
        </td>
         <td>
            API level 21 and later versions
            <br/>
            <br/>
        </td>
    </tr>
     <tr>
        <td>
            All other controls 
            <br/>
            <br/>
        </td>
         <td>
            API level 19 and later versions
            <br/>
            <br/>
        </td>
    </tr>
</table>

## Requirements to run the sample

* [Visual Studio](https://visualstudio.microsoft.com/downloads/) or [Visual Studio for Mac](https://visualstudio.microsoft.com/vs/mac/)

Refer to the following link for more details - [System Requirements](https://help.syncfusion.com/xamarin-android/system-requirements)

## How to run the sample

1. Clone the sample and open it in Visual Studio.

   *Note: If you download the sample using the "Download ZIP" option, right-click it, select Properties, and then select Unblock.*

2. Register your license key as demonstrated in the following code.

		protected override void OnCreate(Bundle savedInstanceState)
        {
            //Register Syncfusion<sup>®</sup> license
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("YOUR LICENSE KEY");

            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
        }
		
	Refer to this [link](https://help.syncfusion.com/xamarin-android/licensing/overview) for more details.

3. Clean and build the application.

4. Run the application.

## License

Syncfusion has no liability for any damage or consequence that may arise by using or viewing the samples. The samples are for demonstrative purposes, and if you choose to use or access the samples, you agree to not hold Syncfusion liable, in any form, for any damage that is related to use, for accessing, or viewing the samples. By accessing, viewing, or seeing the samples, you acknowledge and agree Syncfusion’s samples will not allow you seek injunctive relief in any form for any claim related to the sample. If you do not agree to this, do not view, access, utilize, or otherwise do anything with Syncfusion’s samples.
