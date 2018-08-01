import { AbpCoreBasicTemplatePage } from './app.po';

describe('AbpCoreBasic App', function() {
  let page: AbpCoreBasicTemplatePage;

  beforeEach(() => {
    page = new AbpCoreBasicTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
