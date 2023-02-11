import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { AppComponent } from './app.component';
import { AlertService } from './services/alert.service';
import { ToastrModule } from 'ngx-toastr';
import { HeaderComponent } from './templates/header/header.component';
import { FooterComponent } from './templates/footer/footer.component';
import { NavComponent } from './templates/nav/nav.component';
import { RepositoriosComponent } from './pages/repositorios/repositorios.component';
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';
import { RepositorioComponent } from './pages/repositorio/repositorio.component';
import { ErroInterceptor } from './interceptors/erro.interceptor';
import { FormsModule } from '@angular/forms';

@NgModule({
  declarations: [
    AppComponent,
    HeaderComponent,
    FooterComponent,
    NavComponent,
    RepositoriosComponent,
    RepositorioComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    ToastrModule.forRoot(),
    BrowserAnimationsModule,
    FormsModule 
  ],
  providers: [
    AlertService,
    { provide: HTTP_INTERCEPTORS, useClass: ErroInterceptor, multi: true },
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
