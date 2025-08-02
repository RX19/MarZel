public static class Transiciones
{
    public static async Task FadeInAsync(Form form)
    {
        form.Opacity = 0;
        form.Show();
        for (double i = 0; i <= 1.0; i += 0.05)
        {
            form.Opacity = i;
            await Task.Delay(15);
        }
        form.Opacity = 100;
    }

    public static async Task FadeOutAsync(Form form)
    {
        for (double i = 1.0; i >= 0; i -= 0.05)
        {
            form.Opacity = i;
            await Task.Delay(15);
        }
        form.Hide();
    }
}
