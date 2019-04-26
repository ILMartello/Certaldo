package md518979981b5eb069dc219036c3d3de710;


public class InfoWindowAdapter
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.google.android.gms.maps.GoogleMap.InfoWindowAdapter
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_getInfoContents:(Lcom/google/android/gms/maps/model/Marker;)Landroid/view/View;:GetGetInfoContents_Lcom_google_android_gms_maps_model_Marker_Handler:Android.Gms.Maps.GoogleMap/IInfoWindowAdapterInvoker, Xamarin.GooglePlayServices.Maps\n" +
			"n_getInfoWindow:(Lcom/google/android/gms/maps/model/Marker;)Landroid/view/View;:GetGetInfoWindow_Lcom_google_android_gms_maps_model_Marker_Handler:Android.Gms.Maps.GoogleMap/IInfoWindowAdapterInvoker, Xamarin.GooglePlayServices.Maps\n" +
			"";
		mono.android.Runtime.register ("Parallelo.Maps.Android.InfoWindowAdapter, Parallelo.Maps.Android", InfoWindowAdapter.class, __md_methods);
	}


	public InfoWindowAdapter ()
	{
		super ();
		if (getClass () == InfoWindowAdapter.class)
			mono.android.TypeManager.Activate ("Parallelo.Maps.Android.InfoWindowAdapter, Parallelo.Maps.Android", "", this, new java.lang.Object[] {  });
	}

	public InfoWindowAdapter (md518979981b5eb069dc219036c3d3de710.MapRenderer p0)
	{
		super ();
		if (getClass () == InfoWindowAdapter.class)
			mono.android.TypeManager.Activate ("Parallelo.Maps.Android.InfoWindowAdapter, Parallelo.Maps.Android", "Parallelo.Maps.Android.MapRenderer, Parallelo.Maps.Android", this, new java.lang.Object[] { p0 });
	}


	public android.view.View getInfoContents (com.google.android.gms.maps.model.Marker p0)
	{
		return n_getInfoContents (p0);
	}

	private native android.view.View n_getInfoContents (com.google.android.gms.maps.model.Marker p0);


	public android.view.View getInfoWindow (com.google.android.gms.maps.model.Marker p0)
	{
		return n_getInfoWindow (p0);
	}

	private native android.view.View n_getInfoWindow (com.google.android.gms.maps.model.Marker p0);

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
