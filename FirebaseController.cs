using System.Collections.Generic;
using UnityEngine;
using Firebase.Extensions;
using System;
using System.Threading.Tasks;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Firebase.Auth;
using FirebaseAuth.unitypackage;

public class FirebaseController : MonoBehaviour
{
  public GameObject loginPanel, signupPanel, profilePanel, forgetPasswordPanel,notificationPanel;
 
  public InputField loginEmail, loginPassword, signupEmail, signupPassword, signupUserName,forgetPassEmail;
  
  public Text notif_Title_Text,notif_Message_Text,profileUserName_Text,profileUserEmail_Text;

  public Toggle rememberMe;

  public void OpenLoginPanel(){
    loginPanel.SetActive(true);
    signupPanel.SetActive(false);
    profilePanel.SetActive(false);
    forgetPasswordPanel.SetActive(false);
  }

  public void OpenSignUpPanel(){
    loginPanel.SetActive(false);
    signupPanel.SetActive(true);
    profilePanel.SetActive(false);
     forgetPasswordPanel.SetActive(false);
  }

  public void OpenProfilePanel(){
    loginPanel.SetActive(false);
    signupPanel.SetActive(false);
    profilePanel.SetActive(true);
     forgetPasswordPanel.SetActive(false);
  }
  public void OpenForgetPassPanel(){
    loginPanel.SetActive(false);
    signupPanel.SetActive(false);
    profilePanel.SetActive(true);
     forgetPasswordPanel.SetActive(true);
  }

  public void LoginUser()
  {
    if(string.IsNullorEmpty(loginEmail.text)&&string.IsNullorEmpty(loginPassword.text))
    {
      showNotificationMessage("Error", "Fields Empty.Please Input Deatils In All Fields"); 
      return;
    }
    //do login
  }
public void SignUpUser(){
  if(string.IsNullorEmpty(signupEmail.text) &&string.IsNullorEmpty(signupPassword.text) && string.IsNullorEmpty(signupCPassword.text) && string.IsNullorEmpty(signupUserName.text))
  {
    showNotificationMessage("Error", "Fields Empty.Please Input Deatils In All Fields"); 
    return;
  }
  //do  signup
}
public void forgetPass(){
  if(string.IsNullorEmpty(forgetPassEmail.text))
  {
    showNotificationMessage("Error", "Fields Empty.Please Input Deatils In All Fields"); 
    return;
  }
}

private void showNotificationMessage(string title,string message)
{
    notif_Title_Text.text = "" + title;
    notif_Message_Text.text = "" + message;

    notificationPanel.SetActive(true);
}

public void CloseNotif_Panel()
{
  notif_Title_Text.text = "" ;
  notif_Message_Text.text = "" ;
  notificationPanel.SetActive(false);
}

public void LogOut()
{
  
  profileUserEmail_Text.text = "";
  profileUserName_Text.text = "";
  OpenLoginPanel();
}

}

  