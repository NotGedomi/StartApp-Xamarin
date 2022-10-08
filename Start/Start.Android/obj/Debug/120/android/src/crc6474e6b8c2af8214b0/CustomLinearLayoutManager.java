package crc6474e6b8c2af8214b0;


public class CustomLinearLayoutManager
	extends androidx.recyclerview.widget.LinearLayoutManager
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_canScrollHorizontally:()Z:GetCanScrollHorizontallyHandler\n" +
			"";
		mono.android.Runtime.register ("Sharpnado.HorizontalListView.Droid.Renderers.HorizontalList.CustomLinearLayoutManager, Sharpnado.HorizontalListView.Droid", CustomLinearLayoutManager.class, __md_methods);
	}


	public CustomLinearLayoutManager (android.content.Context p0)
	{
		super (p0);
		if (getClass () == CustomLinearLayoutManager.class) {
			mono.android.TypeManager.Activate ("Sharpnado.HorizontalListView.Droid.Renderers.HorizontalList.CustomLinearLayoutManager, Sharpnado.HorizontalListView.Droid", "Android.Content.Context, Mono.Android", this, new java.lang.Object[] { p0 });
		}
	}


	public CustomLinearLayoutManager (android.content.Context p0, android.util.AttributeSet p1, int p2, int p3)
	{
		super (p0, p1, p2, p3);
		if (getClass () == CustomLinearLayoutManager.class) {
			mono.android.TypeManager.Activate ("Sharpnado.HorizontalListView.Droid.Renderers.HorizontalList.CustomLinearLayoutManager, Sharpnado.HorizontalListView.Droid", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android:System.Int32, mscorlib:System.Int32, mscorlib", this, new java.lang.Object[] { p0, p1, p2, p3 });
		}
	}


	public CustomLinearLayoutManager (android.content.Context p0, int p1, boolean p2)
	{
		super (p0, p1, p2);
		if (getClass () == CustomLinearLayoutManager.class) {
			mono.android.TypeManager.Activate ("Sharpnado.HorizontalListView.Droid.Renderers.HorizontalList.CustomLinearLayoutManager, Sharpnado.HorizontalListView.Droid", "Android.Content.Context, Mono.Android:System.Int32, mscorlib:System.Boolean, mscorlib", this, new java.lang.Object[] { p0, p1, p2 });
		}
	}


	public boolean canScrollHorizontally ()
	{
		return n_canScrollHorizontally ();
	}

	private native boolean n_canScrollHorizontally ();

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
