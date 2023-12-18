
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
/*Refinement to do 
 * Are you using a common way of initialising the Web Driver
 * Generating own Xpath to make code Robust
 */
//Open Chrome Browser
IWebDriver driver = new ChromeDriver();
//Launching Website and Navigating through the page
driver.Navigate().GoToUrl("http://localhost:5000/");
// Login in the Page
IWebElement signInButton = driver.FindElement(By.XPath("//*[@id=\"home\"]/div/div/div[1]/div/a"));
signInButton.Click();
IWebElement emailTextbox = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[1]/input"));
emailTextbox.SendKeys("mailtoshuchigupta@gmail.com");
IWebElement passwordTextbox = driver.FindElement(By.Name("password"));
passwordTextbox.SendKeys("w123elcome");
IWebElement rememberCheckbox = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[3]/div/input"));
rememberCheckbox.Click();
IWebElement loginButton = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[4]/button"));
loginButton.Click();
