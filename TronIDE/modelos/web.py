from selenium import webdriver

drv = None
def init():
	"Inicia o chrome"	

	global drv
	drv = webdriver.Chrome()

init()

#Exemplo de c�digo
drv.get("http://google.com.br")