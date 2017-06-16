using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour {

	// Use this for initialization
	void Start ()
	{
		//verifica se está na cena de nome "Principal"
		if (SceneManager.GetActiveScene ().name == "Fase1")
		{
			GameObject obj = GameObject.Find ("Caixa"); //procura pelo objeto de nome Caixa, que está somente na cena "Principal"
			DontDestroyOnLoad (obj); //define que ele não será destruído ao alterar cenas

			SceneManager.LoadScene ("Fase2"); //muda para a cena de nome "Secundaria"
		}
		else if(SceneManager.GetActiveScene ().name == "Fase2") //está na cena "Secundaria"
		{
			GameObject obj = GameObject.Find ("Caixa"); //procura pelo objeto "Caixa"
			if (obj) //se encontrou objeto
				Debug.Log ("Encontrou em: " + SceneManager.GetActiveScene().name); //mensagem que encontrou
			else
				Debug.Log ("Não encontrou em: " + SceneManager.GetActiveScene().name); //mensagem que não encontrou
		}
	}
}
