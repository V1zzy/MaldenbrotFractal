using System.Xml.Schema;
using System.Numerics;

namespace MaldenbrotSet
{
    public partial class MaldenbrotSetForm : Form
    {
        private double _hx = 0, _hy = 0, _x, _y, _n = 0;
        private Bitmap _bmp;
        private Size _size;
        private double _sizeArea, _scaleArea;
        private Graphics _graphics;
        public MaldenbrotSetForm()
        {
            InitializeComponent();
            _bmp = new(RenderScreen_PB.Width, RenderScreen_PB.Height);
            RenderScreen_PB.Image = _bmp;
            RenderScreen_PB.SizeMode = PictureBoxSizeMode.StretchImage;
            _graphics = Graphics.FromImage(_bmp);

            _size = RenderScreen_PB.Size;
            _sizeArea = 3;
            _scaleArea = 3;

            Render();
            RenderScreen_PB.MouseClick += RenderScreen_PB_Click;
            UpRender_BT.Click += delegate { Uvel(); };
            DownRender_BT.Click += delegate { Umen(); };
        }

        /// <summary>
        /// Увеличение или уменьшение множества клика по Image
        /// </summary>
        private async void RenderScreen_PB_Click(object? sender, MouseEventArgs e)
        {
            int x = e.X,
                y = e.Y;
            switch (e.Button)
            {
                case MouseButtons.Left:
                    _hx = (_hx - _sizeArea / 2) + x * (_sizeArea / _size.Width);
                    _hy = (_hy - _sizeArea / 2) + y * (_sizeArea / _size.Height);
                    _sizeArea /= _scaleArea;
                    await Task.Run(() => Render());
                    break;
                case MouseButtons.Middle:
                    _sizeArea = 3;
                    _scaleArea = 3;
                    await Task.Run(() => Render());
                    break;
                case MouseButtons.Right:
                    _x = (_hx - _sizeArea / 2) + x * (_sizeArea / _size.Width);
                    _y = (_hy - _sizeArea / 2) + y * (_sizeArea / _size.Height);
                    _sizeArea *= _scaleArea;
                    await Task.Run(() => Render());
                    break;
                default:
                    break;
            }
        }
        /// <summary>
        /// Смена цветовой палитры при активации или деактивации colorPalette_CB
        /// </summary>
        private async void ColorPalette_CB_CheckedChanged(object sender, EventArgs e) => await Task.Run(() => Render());

        /// <summary>
        /// Рендерит изображение в Image
        /// </summary>
        private void Render()
        {
            _bmp = new(RenderScreen_PB.Width, RenderScreen_PB.Height);
            _graphics = Graphics.FromImage(_bmp);
            _size = RenderScreen_PB.Size;
            for (var x = 0; x < _size.Width; x += 1)
            {
                _x = (_hx - _sizeArea / 2) + x * (_sizeArea / _size.Width);
                for (var y = 0; y < _size.Height; y += 1)
                {
                    _y = (_hy - _sizeArea / 2) + y * (_sizeArea / _size.Height);
                    var z = new Complex(0, 0);
                    int it = 0;
                    do
                    {
                        it += 1;
                        z = Complex.Pow(z, 2);
                        z = Complex.Add(z, new Complex(_x, _y));
                        if (Complex.Abs(z) > 2.0)
                            break;
                    } while (it < numericUpDownQuality.Value); //глубина фрактала зависит от количества итераций

                    if (colorPalette_CB.Checked)
                        _graphics.DrawRectangle(new Pen(Color.FromArgb(255, it % 16 * 16, it % 8 * 32, it % 4 * 64)), x, y, 1, 1);
                    else
                        _graphics.DrawRectangle(it < numericUpDownQuality.Value ? new Pen(Color.FromArgb(it % 256, it % 256, it % 256)) :
                            new Pen(Color.FromArgb(255, 255, 255)), x, y, 1, 1);
                    UpdateProgressBar(x, y);
                }
            }
            RenderScreen_PB.Image = _bmp;
            RenderScreen_PB.SizeMode = PictureBoxSizeMode.StretchImage;
        }
        /// <summary>
        /// Увеличивает множество внутри Image
        /// </summary>
        private async void Uvel()
        {
            _n = Math.Abs((double)Multiplier_NUD.Value);
            _sizeArea /= _n;
            await Task.Run(() => Render());
        }
        /// <summary>
        /// Уменьшает множество внутри Image
        /// </summary>
        private async void Umen()
        {
            _n = Math.Abs((double)Multiplier_NUD.Value);
            _sizeArea *= _n;
            await Task.Run(() => Render());
        }

        private async void Render_BT_Click(object sender, EventArgs e) => await Task.Run(() => Render());

        private void UpdateProgressBar(int x, int y)
        {
            int progress = (int)((double)(x * _size.Height + y) / (_size.Width * _size.Height) * 100);

            if (progressBar.InvokeRequired)
            {
                progressBar.Invoke(new Action(() => progressBar.Value = progress));
            }
            else
            {
                progressBar.Value = progress;
            }
        }

    }
}
