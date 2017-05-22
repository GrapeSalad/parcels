namespace Parcels.Objects
{
  public class yourParcel
  {
    private float _length;
    private float _width;
    private float _height;
    private float _weight;
    // private string _errorMessage = "";


    public float GetVolume()
    {
      return _length * _width * _height;
    }
    public float GetShipping()
    {
      float shippingCost = _weight + (_length * _width * _height)/ 2;
      return shippingCost;
    }
    public float Getlength()
    {
      return _length;
    }
    public float Getwidth()
    {
      return _width;
    }
    public float Getheight()
    {
      return _height;
    }
    public float Getweight()
    {
      return _weight;
    }
    // public string GetErrorMessage()
    // {
    //   return _errorMessage;
    // }
    public void SetDimensions(string newLength, string newWidth, string newHeight, string newWeight)
    {
      // if ((newLength != "") && (newWidth != "") && (newHeight != "") && (newWeight != ""))
      // {
        _length = float.Parse(newLength);
        _width = float.Parse(newWidth);
        _height = float.Parse(newHeight);
        _weight = float.Parse(newWeight);

      // }
      // else
      // {
      //   _errorMessage = "Error, Please Enter Appropriate Values!";
      // }
    }
  }
}
