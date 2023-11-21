# poligonal_model.py
from model_elements import ModelElements

class Texture:
    pass

class Poligon:
    pass

class PoligonalModel(ModelElements):
    def __init__(self, texture, poligon):
        self.texture = texture
        self.poligon = poligon
