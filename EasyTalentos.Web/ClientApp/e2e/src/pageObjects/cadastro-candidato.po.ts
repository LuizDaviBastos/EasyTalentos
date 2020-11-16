import { browser, element, ExpectedConditions, By } from 'protractor';
import { Conhecimento } from '../../../src/app/models/Conhecimento';
import { Uteis } from '../../../src/assets/lib/Uteis';

export class CadastroCandidatoPo {
  public navigateTo() {

    return browser.get('/', 60000);

  }
  //Candidato
  public get inputNome() { return element(By.id('inputNome')); }
  public get inputEmail() { return element(By.id("inputEmail")); }
  public get inputTelefone() { return element(By.id("inputTelefone")); }
  public get inputLinkedin() { return element(By.id("inputLinkedin")); }
  public get inputCidade() { return element(By.id("inputCidade")); }
  public get inputEstado() { return element(By.id("inputEstado")); }
  public get inputPortfolio() { return element(By.id("inputPortfolio")); }
  public get inputPretencaoSalarial() { return element(By.id("inputPretencaoSalarial")); }

  //Disponibilidade
  public get lblinputateQuatro() { return element(By.id("lblinputateQuatro")); }
  public get lblinputQuatroAteSeis() { return element(By.id("lblinputQuatroAteSeis")); }
  public get lblinputSeisAteOito() { return element(By.id("lblinputSeisAteOito")); }
  public get lblinputAcimaDeOito() { return element(By.id("lblinputAcimaDeOito")); }
  public get lblinputFinaisDeSemana() { return element(By.id("lblinputFinaisDeSemana")); }
  //Preferências
  public get lblinputManha() { return element(By.id("lblinputManha")); }
  public get lblinputTarde() { return element(By.id("lblinputTarde")); }
  public get lblinputNoite() { return element(By.id("lblinputNoite")); }
  public get lblinputMadrugada() { return element(By.id("lblinputMadrugada")); }
  public get lblinputComercial() { return element(By.id("lblinputComercial")); }
  //Conhecimento

  public get inputoutras() { return element(By.id("idOutras")); }
  public get inputlinkCrud() { return element(By.id("idlinkCrud")); }

  public get buttonSubmit() { return element(By.id("submit")); }

  public async cadastrarCandidato() {

    //Candidato
    this.inputNome.sendKeys('Luiz Davi');
    this.inputEmail.sendKeys('davi-sdb@hotmail.com');
    this.inputTelefone.sendKeys('(21) 983791236');
    this.inputLinkedin.sendKeys('http://linkedin.com');
    this.inputCidade.sendKeys('São Gonçalo');
    this.inputEstado.sendKeys('Rio de Janeiro');
    this.inputPortfolio.sendKeys('http://portfolio.com');
    this.inputPretencaoSalarial.sendKeys(2500);



    //Disponibilidade
    this.lblinputateQuatro.click();
    this.lblinputQuatroAteSeis.click();
    this.lblinputSeisAteOito.click();
    this.lblinputAcimaDeOito.click();
    this.lblinputFinaisDeSemana.click();

    //Preferência
    this.lblinputManha.click();
    this.lblinputTarde.click();
    this.lblinputNoite.click();
    this.lblinputMadrugada.click();
    this.lblinputComercial.click();

    //Conhecimento

    /*obtendo propriedades do modelo "Conhecimento"
     * que representem uma linguagem*/
    let properties = new Conhecimento()
      .getProperties().filter(p => p != "outras" &&
        p != "linkCrud" && p != "getProperties");

    /*percorrendo os campos que representam cada linguagem
     * lhe atribuindo um valor*/
    for (let p of properties) {
      await element(By.id(`lbl${p}${Uteis.getRandomInt(0,5)}`)).click();
    }

    

    this.inputoutras.sendKeys("(outras linguagens)");
    this.inputlinkCrud.sendKeys("http://linkcrud.com");

    this.buttonSubmit.click();

    browser.wait(ExpectedConditions.alertIsPresent(), 60000);

    let textoAlert = "";

    await browser.switchTo().alert().then(async result => {
      textoAlert = await result.getText();
      result.accept();
    })

    return textoAlert;
  }


}

