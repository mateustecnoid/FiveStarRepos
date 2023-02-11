import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { RepositorioComponent } from './pages/repositorio/repositorio.component';
import { RepositoriosComponent } from './pages/repositorios/repositorios.component';


const routes: Routes = [
  { path: '', component: RepositoriosComponent },
  { path: 'repositorio/:id', component: RepositorioComponent }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
