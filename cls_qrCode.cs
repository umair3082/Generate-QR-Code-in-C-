using QRCoder;
namespace gym_management_system
{
    class cls_qrCode
    {
         #region qr code

        public void qr_code(string text,PictureBox pb)
        {
            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(text,
                QRCodeGenerator.ECCLevel.Q);
            QRCode qrCode = new QRCode(qrCodeData);
            Bitmap qrCodeImage = qrCode.GetGraphic(20, Color.Black, Color.White, true);
            //Bitmap qrCodeImage = qrCode.GetGraphic(20, Color.DarkRed, Color.White, (Bitmap)pictureBox2.Image);
            pb.Image = qrCodeImage;
        }
        #endregion
    }
    
}
