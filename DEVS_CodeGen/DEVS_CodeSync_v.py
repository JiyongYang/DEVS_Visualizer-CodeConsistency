import xml.etree.ElementTree as ET
import copy
from Model import *

def Read_cm_header(fileName):
    portsLst = []

    f = open(fileName, 'r')
