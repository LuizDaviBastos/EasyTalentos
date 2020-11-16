import { Component } from '@angular/core';
import { TranslateService } from '@ngx-translate/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html'
})
export class AppComponent {

  public langs: string[];

  constructor(private translate: TranslateService) {

    /*translate.addLangs(['en', 'pt-br'])
    this.langs = this.translate.getLangs();*/
   
  }

  public langChange(lang: string) {

    this.translate.use(lang);
    
  }

  title = 'app';
}
