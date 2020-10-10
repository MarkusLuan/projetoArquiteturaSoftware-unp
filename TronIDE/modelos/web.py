from selenium import webdriver
from selenium.webdriver.common.keys import Keys

drv = None
def init():
	"Inicia o chrome"	

	global drv
	drv = webdriver.Chrome()

init()

#Exemplo de código
drv.get("http://google.com.br")
el = drv.find_element_by_id("//*[@id=\"tsf\"]/div[2]/div[1]/div[1]/div/div[2]/input")
el.send_keys("digitando um texto aleatorio")
el.send_keys(Keys.RETURN)