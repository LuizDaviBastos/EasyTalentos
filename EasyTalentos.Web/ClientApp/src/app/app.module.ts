import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { HttpClientModule, HttpClient } from '@angular/common/http';
import { RouterModule } from '@angular/router';
import { TranslateModule, TranslateLoader } from "@ngx-translate/core"
import { TranslateHttpLoader } from "@ngx-translate/http-loader"
import { NgxPaginationModule } from 'ngx-pagination';

import { AppComponent } from './app.component';
import { NavMenuComponent } from './nav-menu/nav-menu.component';
import { HomeComponent } from './home/home.component';
import { FormatTitlePipe } from './pipes/format-title';
import { FormCandidatoComponent } from './custom-component/form-candidato/form-candidato.component';
import { GerenciarCandidatosComponent } from './gerenciar-candidatos/gerenciar-candidatos.component';
import { CandidatoService } from './services/candidato.service';




export function createTranlateLoader(http: HttpClient) {
  return new TranslateHttpLoader(http);
}


@NgModule({
  declarations: [
    AppComponent,
    NavMenuComponent,
    HomeComponent,
    FormCandidatoComponent,
    FormatTitlePipe,
    GerenciarCandidatosComponent
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    NgxPaginationModule,
    TranslateModule.forRoot({
      loader: {
        provide: TranslateLoader,
        useFactory: createTranlateLoader,
        deps: [HttpClient]
      },
      defaultLanguage: 'pt-br'
    }),
    FormsModule,
    
    RouterModule.forRoot([
      { path: '', component: HomeComponent, pathMatch: 'full' },
      { path: 'gerenciar-candidatos', component: GerenciarCandidatosComponent}
    ])
  ],
  providers: [CandidatoService],
  bootstrap: [AppComponent]
})
export class AppModule { }

