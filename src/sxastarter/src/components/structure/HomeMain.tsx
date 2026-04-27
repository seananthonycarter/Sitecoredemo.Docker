import { Placeholder } from '@sitecore-jss/sitecore-jss-nextjs';
import { ComponentProps } from 'lib/component-props';

const HomeMain = (props: ComponentProps): JSX.Element => (
  <div>
    <h1>hello world</h1>
    <section className={'mb-[24px] xl:mb-[40px]'}>
      <h2>hello again</h2>
      <Placeholder name={`pageheader`} rendering={props.rendering} />
    </section>
    <section>
      <Placeholder name={`pagemain`} rendering={props.rendering} />
    </section>
  </div>
);

export default HomeMain;
