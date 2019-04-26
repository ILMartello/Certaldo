package md58ea8f1d1714d9055ec908f7a201ba9ec;


public class BeaconLocator
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.radiusnetworks.ibeacon.MonitorNotifier,
		com.radiusnetworks.ibeacon.RangeNotifier,
		com.radiusnetworks.ibeacon.IBeaconConsumer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_didDetermineStateForRegion:(ILcom/radiusnetworks/ibeacon/Region;)V:GetDidDetermineStateForRegion_ILcom_radiusnetworks_ibeacon_Region_Handler:RadiusNetworks.IBeaconAndroid.IMonitorNotifierInvoker, Android-iBeacon-Service\n" +
			"n_didEnterRegion:(Lcom/radiusnetworks/ibeacon/Region;)V:GetDidEnterRegion_Lcom_radiusnetworks_ibeacon_Region_Handler:RadiusNetworks.IBeaconAndroid.IMonitorNotifierInvoker, Android-iBeacon-Service\n" +
			"n_didExitRegion:(Lcom/radiusnetworks/ibeacon/Region;)V:GetDidExitRegion_Lcom_radiusnetworks_ibeacon_Region_Handler:RadiusNetworks.IBeaconAndroid.IMonitorNotifierInvoker, Android-iBeacon-Service\n" +
			"n_didRangeBeaconsInRegion:(Ljava/util/Collection;Lcom/radiusnetworks/ibeacon/Region;)V:GetDidRangeBeaconsInRegion_Ljava_util_Collection_Lcom_radiusnetworks_ibeacon_Region_Handler:RadiusNetworks.IBeaconAndroid.IRangeNotifierInvoker, Android-iBeacon-Service\n" +
			"n_getApplicationContext:()Landroid/content/Context;:GetGetApplicationContextHandler:RadiusNetworks.IBeaconAndroid.IBeaconConsumerInvoker, Android-iBeacon-Service\n" +
			"n_bindService:(Landroid/content/Intent;Landroid/content/ServiceConnection;I)Z:GetBindService_Landroid_content_Intent_Landroid_content_ServiceConnection_IHandler:RadiusNetworks.IBeaconAndroid.IBeaconConsumerInvoker, Android-iBeacon-Service\n" +
			"n_onIBeaconServiceConnect:()V:GetOnIBeaconServiceConnectHandler:RadiusNetworks.IBeaconAndroid.IBeaconConsumerInvoker, Android-iBeacon-Service\n" +
			"n_unbindService:(Landroid/content/ServiceConnection;)V:GetUnbindService_Landroid_content_ServiceConnection_Handler:RadiusNetworks.IBeaconAndroid.IBeaconConsumerInvoker, Android-iBeacon-Service\n" +
			"";
		mono.android.Runtime.register ("Parallelo.Android.BeaconLocator, Parallelo.Android", BeaconLocator.class, __md_methods);
	}


	public BeaconLocator ()
	{
		super ();
		if (getClass () == BeaconLocator.class)
			mono.android.TypeManager.Activate ("Parallelo.Android.BeaconLocator, Parallelo.Android", "", this, new java.lang.Object[] {  });
	}


	public void didDetermineStateForRegion (int p0, com.radiusnetworks.ibeacon.Region p1)
	{
		n_didDetermineStateForRegion (p0, p1);
	}

	private native void n_didDetermineStateForRegion (int p0, com.radiusnetworks.ibeacon.Region p1);


	public void didEnterRegion (com.radiusnetworks.ibeacon.Region p0)
	{
		n_didEnterRegion (p0);
	}

	private native void n_didEnterRegion (com.radiusnetworks.ibeacon.Region p0);


	public void didExitRegion (com.radiusnetworks.ibeacon.Region p0)
	{
		n_didExitRegion (p0);
	}

	private native void n_didExitRegion (com.radiusnetworks.ibeacon.Region p0);


	public void didRangeBeaconsInRegion (java.util.Collection p0, com.radiusnetworks.ibeacon.Region p1)
	{
		n_didRangeBeaconsInRegion (p0, p1);
	}

	private native void n_didRangeBeaconsInRegion (java.util.Collection p0, com.radiusnetworks.ibeacon.Region p1);


	public android.content.Context getApplicationContext ()
	{
		return n_getApplicationContext ();
	}

	private native android.content.Context n_getApplicationContext ();


	public boolean bindService (android.content.Intent p0, android.content.ServiceConnection p1, int p2)
	{
		return n_bindService (p0, p1, p2);
	}

	private native boolean n_bindService (android.content.Intent p0, android.content.ServiceConnection p1, int p2);


	public void onIBeaconServiceConnect ()
	{
		n_onIBeaconServiceConnect ();
	}

	private native void n_onIBeaconServiceConnect ();


	public void unbindService (android.content.ServiceConnection p0)
	{
		n_unbindService (p0);
	}

	private native void n_unbindService (android.content.ServiceConnection p0);

	private java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}
