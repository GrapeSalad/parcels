namespace Parcels.Objects
{
  public class yourParcel
  {
    private float _length;
    private float _width;
    private float _height;
    private float _weight;

    public string GetVolume()
    {
      float volume = _length * _width * _height;
      return volume;
    }
    public string GetShipping()
    {
      float shippingCost = _weight * volume / 2;
      return shippingCost;
    }

    public void SetDimensions(float newLength; float newWidth; float newHeight; float newWeight )
    {
      _length = newLength;
      _width = newWidth;
      _height = newHeight;
      _weight = newWeight;
    }
  }
}
