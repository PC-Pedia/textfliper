
// This file has been generated by the GUI designer. Do not modify.

public partial class MainWindow
{
	private global::Gtk.VBox vbox1;
	private global::Gtk.ScrolledWindow PadOne;
	private global::Gtk.TextView PadOne1;
	private global::Gtk.Button FlipIt;
	private global::Gtk.ScrolledWindow GtkScrolledWindow1;
	private global::Gtk.TextView PadTwo;
	
	protected virtual void Build ()
	{
		global::Stetic.Gui.Initialize (this);
		// Widget MainWindow
		this.Name = "MainWindow";
		this.Title = global::Mono.Unix.Catalog.GetString ("Flip It Kary!");
		this.WindowPosition = ((global::Gtk.WindowPosition)(4));
		// Container child MainWindow.Gtk.Container+ContainerChild
		this.vbox1 = new global::Gtk.VBox ();
		this.vbox1.Name = "vbox1";
		// Container child vbox1.Gtk.Box+BoxChild
		this.PadOne = new global::Gtk.ScrolledWindow ();
		this.PadOne.Name = "PadOne";
		this.PadOne.ShadowType = ((global::Gtk.ShadowType)(1));
		// Container child PadOne.Gtk.Container+ContainerChild
		this.PadOne1 = new global::Gtk.TextView ();
		this.PadOne1.CanFocus = true;
		this.PadOne1.Name = "PadOne1";
		this.PadOne1.Justification = ((global::Gtk.Justification)(3));
		this.PadOne1.WrapMode = ((global::Gtk.WrapMode)(2));
		this.PadOne1.LeftMargin = 20;
		this.PadOne1.RightMargin = 20;
		this.PadOne.Add (this.PadOne1);
		this.vbox1.Add (this.PadOne);
		global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.PadOne]));
		w2.Position = 0;
		// Container child vbox1.Gtk.Box+BoxChild
		this.FlipIt = new global::Gtk.Button ();
		this.FlipIt.CanFocus = true;
		this.FlipIt.Name = "FlipIt";
		this.FlipIt.UseUnderline = true;
		this.FlipIt.Label = global::Mono.Unix.Catalog.GetString ("Flip it Kary!");
		this.vbox1.Add (this.FlipIt);
		global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.FlipIt]));
		w3.Position = 1;
		w3.Expand = false;
		w3.Fill = false;
		// Container child vbox1.Gtk.Box+BoxChild
		this.GtkScrolledWindow1 = new global::Gtk.ScrolledWindow ();
		this.GtkScrolledWindow1.Name = "GtkScrolledWindow1";
		this.GtkScrolledWindow1.ShadowType = ((global::Gtk.ShadowType)(1));
		// Container child GtkScrolledWindow1.Gtk.Container+ContainerChild
		this.PadTwo = new global::Gtk.TextView ();
		this.PadTwo.CanFocus = true;
		this.PadTwo.Name = "PadTwo";
		this.PadTwo.Justification = ((global::Gtk.Justification)(3));
		this.PadTwo.WrapMode = ((global::Gtk.WrapMode)(2));
		this.PadTwo.LeftMargin = 20;
		this.PadTwo.RightMargin = 20;
		this.GtkScrolledWindow1.Add (this.PadTwo);
		this.vbox1.Add (this.GtkScrolledWindow1);
		global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.GtkScrolledWindow1]));
		w5.Position = 2;
		this.Add (this.vbox1);
		if ((this.Child != null)) {
			this.Child.ShowAll ();
		}
		this.DefaultWidth = 400;
		this.DefaultHeight = 300;
		this.Show ();
		this.DeleteEvent += new global::Gtk.DeleteEventHandler (this.OnDeleteEvent);
		this.FlipIt.Clicked += new global::System.EventHandler (this.OnFlipButton);
	}
}
