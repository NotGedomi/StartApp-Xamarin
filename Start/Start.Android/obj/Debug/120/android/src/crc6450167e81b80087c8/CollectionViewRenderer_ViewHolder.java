package crc6450167e81b80087c8;


public class CollectionViewRenderer_ViewHolder
	extends androidx.recyclerview.widget.RecyclerView.ViewHolder
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("Sharpnado.CollectionView.Droid.Renderers.CollectionViewRenderer+ViewHolder, Sharpnado.CollectionView.Droid", CollectionViewRenderer_ViewHolder.class, __md_methods);
	}


	public CollectionViewRenderer_ViewHolder (android.view.View p0)
	{
		super (p0);
		if (getClass () == CollectionViewRenderer_ViewHolder.class) {
			mono.android.TypeManager.Activate ("Sharpnado.CollectionView.Droid.Renderers.CollectionViewRenderer+ViewHolder, Sharpnado.CollectionView.Droid", "Android.Views.View, Mono.Android", this, new java.lang.Object[] { p0 });
		}
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
