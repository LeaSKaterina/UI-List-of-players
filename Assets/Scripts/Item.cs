using PolyAndCode.UI;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Item : MonoBehaviour, ICell
{
    public Image Avatar;
    public Text Username;
    public Text Points;

    public void ConfigureItem(PersonData personData)
    {
        if (personData == null)
        {
            Debug.LogError("Item has no PersonData!");
            return;
        }
        StartCoroutine(LoadPhoto(personData.AvatarUrl));
        Username.text = personData.Username;
        Points.text = personData.Points.ToString();
    }
    IEnumerator LoadPhoto(string url)
    {
        var tex = new Texture2D(4, 4, TextureFormat.DXT1, false);
        WWW www = new WWW(url);
        yield return www;
        www.LoadImageIntoTexture(tex);
        Avatar.sprite = Sprite.Create(tex, new Rect(0, 0, tex.width, tex.height), new Vector2(0.5f, 0.5f), 100);
    }
}
