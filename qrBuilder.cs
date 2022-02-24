using QRCoder;

namespace qr_generator
{
    class qrBuilder
    {

		private const QRCodeGenerator.ECCLevel correctionLevel = QRCodeGenerator.ECCLevel.Q;
		private const int resolution = 5;
        private readonly string _content;
		private readonly string _fileName;

		public qrBuilder(string content, string fileName)
		{
			_content = content;
			_fileName = fileName;
		}

		public void Execute()
		{
			var qrcode = new QRCode(new QRCodeGenerator().CreateQrCode(_content, correctionLevel, false, false, 0, -1));
			qrcode.GetGraphic(resolution).Save(_fileName);
		}

	}
}
