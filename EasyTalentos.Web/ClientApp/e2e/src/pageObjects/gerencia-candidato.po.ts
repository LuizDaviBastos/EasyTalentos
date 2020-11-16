import { browser, By, element, ExpectedConditions, protractor } from 'protractor'

export class GerenciaCandidatoPoGerenciaCandidatoPo {

  public navigateTo() {
    browser.get('/gerenciar-candidatos');
  }

  public get table() { return element(By.id("tblCandidatos")); }

  public get buttonOptions() { return element(By.id("btnOptions")); }
  public get buttonEditar() { return element(By.id("btnEditarCandidato")); }
  public get buttonExcluir() { return element(By.id("btnExcluirCandidato")); }
  public get modalCandidato() { return element(By.id("modalCandidato")); }

  public get inputNome() { return element(By.id("inputNome")); }
  public get buttonSalvar() { return element(By.id("submit")); }


  public async editarCandidato() {

    //Espere até que a tabela esteja visível
    browser.wait(ExpectedConditions.visibilityOf(this.table));

    this.buttonOptions.click();
    this.buttonEditar.click();

    browser.wait(ExpectedConditions.visibilityOf(this.modalCandidato));

    await this.inputNome.getAttribute('value').then(result => {

      if (result != "NomeTeste2") {
        this.inputNome.clear();
        this.inputNome.sendKeys("NomeTeste2");
      }
      else {
        this.inputNome.clear();
        this.inputNome.sendKeys("NomeTeste1");
      }
    });

    this.buttonSalvar.click();

    browser.wait(ExpectedConditions.alertIsPresent(), 60000);

    let textoAlert = "";
    await browser.switchTo().alert().then(async result => {
      textoAlert = await result.getText();
      result.accept();
    });

    return textoAlert;

  }

  public async excluirCandidato() {

    //Espere até que a tabela esteja visível
    browser.wait(ExpectedConditions.visibilityOf(this.table));

    this.buttonOptions.click();
    this.buttonExcluir.click();

    browser.wait(ExpectedConditions.alertIsPresent(), 10000);

    await browser.switchTo().alert().then(question => {
      question.accept();
    });

    browser.wait(ExpectedConditions.alertIsPresent(), 60000);


    let textAlert = "";

    await browser.switchTo().alert().then(async result => {
      textAlert = await result.getText();
      result.accept();
    });

    return textAlert;

  }
}
