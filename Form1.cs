namespace Keep;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    protected override void SetVisibleCore(bool value)
    {
        if (!IsHandleCreated)
        {
            CreateHandle();
        }

        base.SetVisibleCore(false);
    }

    private void exitToolStripMenuItem_Click(object sender, EventArgs e)
    {
        Close();
    }
}
