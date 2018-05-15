import enum

@enum.unique
class Type(enum.Enum):
    IN = 1
    OUT = 2

class Coupling:
    def __init__(self, _from, _fPort, _to, _tPort):
        self.cFrom = _from
        self.cFPort = _fPort
        self.cTo = _to
        self.cTPort = _tPort
    def __str__(self):
        return " <--> [From]: {}/[FPort]: {} >>>> [To]: {}/[TPort]: {}".format(self.cFrom, self.cFPort, self.To, self.TPort)

class Port:
    def __init__(self, _type, _name):
        self.cType = _type
        self.cName = _name
    def __str__(self):
        return "Type : {},  Name : {}".format(self.cType, self.cName)

class Model:
    def __init__(self, _name, _fullname, _type):
        self.cName = _name
        self.cFullname = _fullname
        self.cType = _type
        self.cPorts = []
        self.cCouplings = []
        self.cInstances = []

    def __str__(self):
        return "-------[Model Info]-------\n"\
        "@ Name: {}\n@ Fullname: {}\n@ Type: {}\n"\
        "@ Ports: {}\n@ Coupling: {}\n@ Instances: {}"\
        "\n--------------------------".format(self.cName, self.cFullname, self.cType, self.cPorts, self.cCouplings, self.cInstances)
