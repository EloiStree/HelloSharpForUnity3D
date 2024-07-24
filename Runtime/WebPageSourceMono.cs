
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Represents a web page source, and provides a method to open the source in the default browser.
/// </summary>
public class WebPageSourceMono : MonoBehaviour
{
    public string m_sourceUrl;
    [ContextMenu("Open Source in Browser")]
    public void OpenSourceInDefaultBrowser() {
        Application.OpenURL(m_sourceUrl);
    }

    public void SetSourceUrl(string url) {
        m_sourceUrl = url;
    }
    public string GetSourceUrl() {
        return m_sourceUrl;
    }
}
