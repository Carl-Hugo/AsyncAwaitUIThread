using System.Collections.Concurrent;

namespace AsyncAwaitUIThread;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private async void btn_start1_Click(object sender, EventArgs e)
        => await CancellableCounter.Start(label1);
    private async void btn_stop1_Click(object sender, EventArgs e)
        => await CancellableCounter.Stop(label1);

    private async void btn_start2_Click(object sender, EventArgs e)
        => await CancellableCounter.Start(label2);
    private async void btn_stop2_Click(object sender, EventArgs e)
        => await CancellableCounter.Stop(label2);

    private async void btn_start3_Click(object sender, EventArgs e)
        => await CancellableCounter.Start(label3);
    private async void btn_stop3_Click(object sender, EventArgs e)
        => await CancellableCounter.Stop(label3);
}

public static class CancellableCounter
{
    private static readonly ConcurrentDictionary<string, CancellationTokenSource> cancellationTokenSources = new();

    public static async ValueTask Start(Label label)
    {
        if (cancellationTokenSources.ContainsKey(label.Name))
        {
            return;
        }
        var cancellationTokenSource = cancellationTokenSources
            .GetOrAdd(label.Name, (name) => new CancellationTokenSource());
        await Execute(label, cancellationTokenSource.Token);
    }

    public static async ValueTask Stop(Label label)
    {
        if (!cancellationTokenSources.ContainsKey(label.Name))
        {
            return;
        }
        await cancellationTokenSources[label.Name].CancelAsync();
        _ = cancellationTokenSources.Remove(label.Name, out _);
    }

    private static async ValueTask Execute(Label label, CancellationToken cancellationToken)
    {
        for (var i = 0; i < int.MaxValue; i++)
        {
            label.Text = i.ToString();
            await Task.Delay(10);
            if (cancellationToken.IsCancellationRequested)
            {
                break;
            }
        }
    }
}