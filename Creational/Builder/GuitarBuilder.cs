namespace Builder;

public class GuitarBuilder
{
    private Guitar guitar = new Guitar();

    public Guitar Build()
    {
        return guitar;
    }

    public GuitarBuilder SetNeck(string neck)
    {
        guitar.Neck = neck;
        return this;
    }

    public GuitarBuilder SetFingerboard(string fingerboard)
    {
        guitar.Fingerboard = fingerboard;
        return this;
    }

    public GuitarBuilder SetHeadType(string headType)
    {
        guitar.HeadType = headType;
        return this;
    }

    public GuitarBuilder SetNut(string nut)
    {
        guitar.Nut = nut;
        return this;
    }

    public GuitarBuilder SetFrets(string frets)
    {
        guitar.Frets = frets;
        return this;
    }

    public GuitarBuilder SetSaddle(string saddle)
    {
        guitar.Saddle = saddle;
        return this;
    }

    public GuitarBuilder SetBridge(string bridge)
    {
        guitar.Bridge = bridge;
        return this;
    }

    public GuitarBuilder SetStrings(string strings)
    {
        guitar.Strings = strings;
        return this;
    }

    public GuitarBuilder SetBody(string body)
    {
        guitar.Body = body;
        return this;
    }
}
