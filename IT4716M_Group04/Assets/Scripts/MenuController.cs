using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
	public GameObject mainMenu;
	public GameObject settingMenu;
	public Slider soundSlider;
	public AudioSource bgm;
	AudioSource clickSound;
	private void Start()
    {
		clickSound = GetComponent<AudioSource>();
	}

    public void Update()
    {
		bgm.volume = soundSlider.value;
		clickSound.volume = soundSlider.value;
		if (Input.GetKey(KeyCode.Escape))
        {
			OpenMainMenu();
        }
    }
    public void OpenMainMenu()
	{
		Time.timeScale = 0;
		mainMenu.SetActive(true);
		settingMenu.SetActive(false);
	}
	public void OpenSetting()
	{
		Time.timeScale = 0;
		settingMenu.SetActive(true);
		mainMenu.SetActive(false);
	}
	public void CloseMenu()
    {
		Time.timeScale = 1;
		settingMenu.SetActive(false);
		mainMenu.SetActive(false);
	}

	public void ExitGame()
	{
		Time.timeScale = 1;
		SceneManager.LoadScene("Menu");
	}
	public void Mute()
    {
		soundSlider.value = 0;
    }
	public void Unmute()
	{
		soundSlider.value = 1;
	}
	public void click()
    {
		clickSound.Play();
    }
	public void QuitGame()
    {
		Application.Quit();
    }
}
