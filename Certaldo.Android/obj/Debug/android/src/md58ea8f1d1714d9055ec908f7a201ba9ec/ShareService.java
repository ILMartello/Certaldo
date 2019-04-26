package md58ea8f1d1714d9055ec908f7a201ba9ec;


public class ShareService
	extends android.app.Activity
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("Parallelo.Android.ShareService, Parallelo.Android", ShareService.class, __md_methods);
	}


	public ShareService ()
	{
		super ();
		if (getClass () == ShareService.class)
			mono.android.TypeManager.Activate ("Parallelo.Android.ShareService, Parallelo.Android", "", this, new java.lang.Object[] {  });
	}

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
