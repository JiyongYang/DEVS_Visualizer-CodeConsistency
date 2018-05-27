import xml.etree.ElementTree as ET
import copy
from Model import *

def Read_cm_header(fileName):
    portsLst = []
    flg = False
    f = open(fileName, 'r')

    while True:
        line = f.readline()
        if not line: break
        # find ports
        if(line.strip() == "// [Region] Ports"):
            flg = True
        if (line.strip() == "// [EndRegion] Ports"):
            flg = False

        if(flg == True):
            print(line.strip().split()[-1].replace(";", ""))

    f.close()

Read_cm_header("Outmost.h")