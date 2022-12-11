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

    private void esToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
    {
        if (sender is ToolStripMenuItem menuItem && menuItem.Checked)
        {
            foreach (var item in new[] { displayToolStripMenuItem, systemToolStripMenuItem })
            {
                if (item != menuItem)
                {
                    item.Checked = false;
                }
            }
        }

        _ = Interop.SetThreadExecutionState(Interop.EXECUTION_STATE.ES_CONTINUOUS
            | (displayToolStripMenuItem.Checked ? Interop.EXECUTION_STATE.ES_DISPLAY_REQUIRED : 0)
            | (systemToolStripMenuItem.Checked ? Interop.EXECUTION_STATE.ES_SYSTEM_REQUIRED : 0));
    }
}
