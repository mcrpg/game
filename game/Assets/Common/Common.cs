using System.Collections;
using System.Collections.Generic;
using System.IO;

using UnityEngine;

using Game.Common.Controller;

using Game.Infrastructure.Models;
using Game.Infrastructure.Models.Interfaces;
using Game.Infrastructure.Utils;

namespace Game.Common
{
    public class Common : MonoBehaviour
    {
    	public static Common Context;
    	
    	public GameObject gameStatic_Border;
    	public GameObject gameStatic_Light;
    	public GameObject playerGameObject;
    	
    	public GameModelsTemplates GameModelsTemplates;
    	
        public ILevel level;
        
        ~Common()
        {
        	BaseController.CallOnDisabled();
        }

        private void Start()
        {
        	Context = this;
        	
        	DefaultControllersInitializer.InitializeAll();
        	BaseController.CallOnEnabled();
        	
        	Application.Log("Game started.");
        }
        
        private void Update()
        {
            BaseController.CallOnUpdate();
        }
    }
}