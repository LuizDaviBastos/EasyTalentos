import { parse } from "url";

export class Conhecimento {

  id: number;
  ionic: number = undefined;
  reactJs: number = undefined;
  reactNative: number = undefined;
  android: number = undefined;
  flutter: number = undefined;
  swift: number = undefined;
  ios: number = undefined;
  html: number = undefined;
  css: number = undefined;
  bootstrap: number = undefined;
  jquery: number = undefined;
  angularJs: number = undefined;
  angular: number = undefined;
  java: number = undefined;
  python: number = undefined;
  flask: number = undefined;
  aspNetMvc: number = undefined;
  aspNetWebForm: number = undefined;
  c: number = undefined;
  cSharp: number = undefined;
  nodeJs: number = undefined;
  expressNodeJs: number = undefined;
  cake: number = undefined;
  dJango: number = undefined;
  majento: number = undefined;
  php: number = undefined;
  vue: number = undefined;
  wordPress: number = undefined;
  ruby: number = undefined;
  mySqlServer: number = undefined;
  mySql: number = undefined;
  salesForce: number = undefined;
  photoshop: number = undefined;
  illustrator: number = undefined;
  seo: number = undefined;
  laravel: number = undefined;
  outras: string = "";
  linkCrud: string = "";

  getProperties() {
    var lista = [];
    for (var item in this) {

      lista.push(item);
    }
    return lista;
  }

  /*getValue(obj: Extract<keyof this, string>) {
    return this[obj];
  }*/

}
